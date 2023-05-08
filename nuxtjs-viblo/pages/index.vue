<template>
  <section class="container">
    <div class="content">
      <label-content
        @loadFromLocalStorage="loadFromLocalStorage"
        label="Lời chào"
      />
      <label-content @saveToLocalStorage="saveToLocalStorage" label="Cảm ơn" />
      <!-- @click="clickHandler(group,index)" -->
      <div v-for="(group, index) in form.phases" :key="index">
        <group-item-content
          :title="group.title"
          :group-id="group.id"
          :group-title="group.title"
          :items="group.items"
          :group-index="index"
          :active="index === activeGroup"
          :isRequired="group.isRequired"
          @changeRequired="handleGroupChangeRequired"
          @add-item="addItemToGroup(index, $event)"
          @delete-item="deleteItem"
          @delete-group="deleteGroup"
          @update-group="updateGroup"
          @activate="activateGroup(index)"
        />
      </div>
      <label-content label="Thêm thành phần" @add-row="addNewPhase" />

      <!-- <button @click="saveToLocalStorage">Save to Local Storage</button>
      <button @click="loadFromLocalStorage">Load from Local Storage</button> -->
      <!-- <v-btn color="primary">Click me!</v-btn> -->
    </div>
  </section>
</template>

<script>
import AppLogo from "~/components/AppLogo.vue";

import LabelContent from "~/components/LabelContent.vue";
import GroupItemContent from "~/components/GroupItemContent.vue";
import { v4 as uuidv4 } from "uuid";

export default {
  components: {
    AppLogo,
    LabelContent,
    GroupItemContent,
  },
  data() {
    return {
      form: {
        id: "cbe48b2c-cb6b-43c5-8afa-c7bfafde006c",
        version: 36,
        owner: "kieucb@gmail.com",
        title: "Đánh giá kết quả sử dụng GOV O2",
        description: "Đánh giá kết quả sử dụng GOV O2",
        is_published: false,
        is_limit_to_one: true,
        require_login: false,
        require_captcha: false,
        can_edit_response: false,
        max_num_response: -1,
        registered_at: "2023-03-09T17:42:01.827000+07:00",
        updated_at: "2023-03-17T17:51:20.206000+07:00",
        properties: {
          font_family: "Georgia, serif",
          font_size: 13,
          font_color: "black",
          banner:
            "/static/vnform/image/47e32ff5-5c09-4fca-bb6c-f47c66d2622b.jpg",
          header_title: "Tiêu đề chào mừng",
          header_description: "Hướng dẫn nhập biểu mẫu, abc",
          header_color: "blue",
          header_logo: "default",
          footer_title: "",
          footer_subtitle: "",
          footer_caption: "",
          footer_href: "",
          footer_color: "",
          unpublished_message: "",
        },
        phases: [
        // {
        //   id:uuidv4(),
        //   title: "",
        //   items: [],
        // },
      ],
      },

      activeGroup: null,
    };
  },
  mounted() {
    this.loadFromLocalStorage();
  },
  methods: {
    addItemToGroup(index, newItem) {
      this.$router.push({
        name: "item-id",
        params: { id: newItem.id, group_item: newItem, group_index: index },
        query: { item: newItem, group_index: index },
      });
    },

    addNewPhase() {
      const newGroup = {
        id: uuidv4(),
        title: "New Group",
        required: false,
        items: [],
      };
      this.form.phases.push(newGroup);
      this.saveToLocalStorage();
    },
    // clickHandler(item) {
    //   console.log(item);
    //   this.groupIndex = item.index;
    // },
    deleteItem(groupIndex, itemIndex) {
      this.form.phases[groupIndex].items.splice(itemIndex, 1);
      this.saveToLocalStorage();
    },
    deleteGroup(groupIndex) {
      if (groupIndex > 0) {
        if (window.confirm("Are you sure you want to delete this group?")) {
          this.form.phases.splice(groupIndex, 1);
          this.saveToLocalStorage();
        }
      } else alert("Biểu mẫu chỉ còn lại 1 thành phần");
    },
    activateGroup(index) {
      this.activeGroup = index;
    },
    saveToLocalStorage() {
      localStorage.setItem("myObject", JSON.stringify(this.form));
    },
    loadFromLocalStorage() {
      const savedObject = localStorage.getItem("myObject");
      if (savedObject) {
        this.form = JSON.parse(savedObject);
      }
    },
    updateGroup(groupIndex, title) {
      this.form.phases[groupIndex].title = title;
      this.saveToLocalStorage();
    },
    handleGroupChangeRequired(groupIndex, groupRequired) {
      this.form.phases[groupIndex].required = groupRequired;
      console.log(this.form.phases[groupIndex]);
    },
  },
};
</script>

<style>
.container {
  position: relative;
  background: #f4f4f4;
}
.content {
  /* Auto layout */
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  padding: 48px 423px;
  gap: 24px;
  overflow: hidden;
  position: absolute;
  max-height: calc(100vh - 130px);
  width: 100%;
  overflow: auto;
  position: absolute;
  top: 120px;
}
</style>

